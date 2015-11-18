using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using MetroFramework;
using function;

namespace Desktop_IDE
{
    public static class tcpserver
    {
        #region Constants
        private const int c_bufferSize = 5242880;
        #endregion

        #region Members
        private static List<Socket> _clientSockets = new List<Socket>();
        private delegate void AddClientHandler(IPEndPoint IpEndPoint);
        private delegate void EnableSendHandler();
        public static Main Server { get; set; }
        private static byte[] _buffer = new byte[1024];
        private static Socket _serverSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        #endregion


        public static void SetupServer()
        {
            try
            {
                _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            }
            catch (SocketException ex)
            {
                MetroMessageBox.Show(Server, ex.Message);
                return;
            }
            _serverSocket.Listen(100);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallBack),null);

        }
        private static void AcceptCallBack(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            _clientSockets.Add(socket);

            IPEndPoint ipEndPoint = (IPEndPoint)socket.RemoteEndPoint;

            if ((ipEndPoint) != null)
            {
                Server.BeginInvoke(new AddClientHandler(Server.AddClient), ipEndPoint);
            }

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceivedCallback), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
        }
        private static void ReceivedCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);
            string text = Encoding.ASCII.GetString(dataBuf);


            string response = string.Empty;
            if (text.ToLower() == "get file")
            {
                #region veeeeeeeeeery loooooooooong loooooooop
                int i = 0;
                string temp = string.Empty;
                for (;i < strData.strQuestion.Length;i++)
                {
                    if(string.IsNullOrEmpty(strData.strQuestion[i]))
                    {
                        break;
                    }
                    else
                        temp += "<" + (i + 1).ToString() + ">" + "<Q>:" + strData.strQuestion[i] + "\n";
                    
                    for(int j = 0;j <4;j++)
                    {
                        if(j == 0)
                        {
                            temp += "<" + (i + 1).ToString() + ">" + "<A>:";
                        }
                        else if (j == 1)
                        {
                            temp += "<" + (i + 1).ToString() + ">" + "<B>:";

                        }
                        else if(j == 2)
                        {
                            temp += "<" + (i + 1).ToString() + ">" + "<C>:";
                        }
                        else if(j==3)
                        {
                            temp += "<" + (i + 1).ToString() + ">" + "<D>:";
                        }
                        temp += strData.strAnswer[j][i] + "\n";
                    }
                }
                response = "Max:" + i.ToString() + "\n" + temp;
#endregion

                
            }
            else if(text.ToLower() == "hahaha")
            {
                response = DateTime.Now.ToLongTimeString();
            }
            else
            {
                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceivedCallback), socket);
            }
            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallBack), socket);

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceivedCallback), socket);

        }

        
        private static void SendCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }
        private static void SendCallBackFile(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSendFile(AR);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
        
    }
}
