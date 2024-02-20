using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Communication
{
    public class CommunicationHelper
    {
        private Socket soket;
        private NetworkStream stream;
        private BinaryFormatter formatter;
        public CommunicationHelper(Socket soket)
        {
            this.soket = soket;
            stream = new NetworkStream(soket);
            formatter = new BinaryFormatter();
        }

        public void Send<T>(T obj) where T : class
        {
            formatter.Serialize(stream, obj);
        }
        public T Receive<T>() where T : class
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}
