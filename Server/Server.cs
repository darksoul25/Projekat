using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        public static List<ClientHandler> clients = new List<ClientHandler>();
        private Socket osluskujuciSoket;
        public Server()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }
        public void Start()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                osluskujuciSoket.Bind(endPoint);
                osluskujuciSoket.Listen(5);
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>" + ex.Message);
            }
        }
        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = osluskujuciSoket.Accept();
                    ClientHandler hendler = new ClientHandler(klijentskiSoket);
                    clients.Add(hendler);
                    Thread nitKlijenta = new Thread(hendler.HandleRequest);
                    nitKlijenta.IsBackground = true;
                    nitKlijenta.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>" + ex.Message);
            }

        }
        public void Stop()
        {
            osluskujuciSoket?.Close();
            osluskujuciSoket = null;
            foreach (ClientHandler c in clients)
            {
                c.Close();
            }
        }

    }
}
