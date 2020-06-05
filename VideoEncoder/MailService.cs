namespace VideoEncoder
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine("Sending Email..." + args.Video.Title);
        }
    }
}
