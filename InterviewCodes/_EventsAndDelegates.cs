using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodes
{
    public class VideoEncoder   
    {
        //declaration of event delegate (VideoEncodedEventHandler -- based on naming convention)
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler videoEncoded;

        public void Encode(Video video)
        {
            //encoding logic--


            //Tightly coupled code below
            //MailService.Send();
            //MessageService.Send();

            // ReSharper disable once InvalidXmlDocComment
            /**
             * Now, instead of depending on other class (to make code extensible)
             * we can create a publisher event here and make classes subscriber to this as needed
             */
            OnVideoEncoded();
        }

        //protected, virtual, void and the name itself are base on EVENT PUBLISHER METHOD convention of .net
        protected virtual void OnVideoEncoded()
        {
            if (videoEncoded != null)
            {
                videoEncoded(this, EventArgs.Empty);
            }
        }
    }

    public class Video
    {
    }

    public class MailService
    {
        public static void Send()
        {
            Console.WriteLine("Email sent");
        }

        //Make subscriber
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Email sent");
        }
    }

    public class MessageService
    {
        public static void Send()
        {
            Console.WriteLine("SMS sent");
        }

        //Make subscriber
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("SMS sent");
        }
    }
}
