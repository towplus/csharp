using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
class ClientHadler
{
    NetworkStream stream = null;
    StreamReader reader = null;
    StreamWriter writer = null;
    Socket socket = null;
    public ClientHadler(Socket socket)
    {
        this.socket = socket;
        Server.list.Add(socket);
    }
    public void chat()
    {
        Encoding encode = Encoding.GetEncoding("euc-kr");
        stream = new NetworkStream(socket);
        reader = new StreamReader(stream, encode);
        try
        {
            while (true)
            {
                string str = reader.ReadLine();
                Console.WriteLine(str);
                foreach (Socket s in Server.list)
                {
                    stream = new NetworkStream(s);
                    writer = new StreamWriter(stream, encode) { AutoFlush = true };
                    writer.WriteLine(str);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            Server.list.Remove(socket);
            socket.Close();
            socket = null;
        }
    }
}
class Server
{
    public static List<Socket> list = new List<Socket>();

    public static void Main()
    {
        TcpListener tcpListener = null;
        Socket clientsocket = null;
        try
        {
            IPAddress ipAd = IPAddress.Parse("192.168.0.209");
            tcpListener = new TcpListener(ipAd, 5001);
            tcpListener.Start();
            while (true)
            {
                clientsocket = tcpListener.AcceptSocket();
                ClientHadler cHandler = new ClientHadler(clientsocket);
                Thread t = new Thread(new ThreadStart(cHandler.chat));
                t.Start();
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            clientsocket.Close();
        }
    }
}
