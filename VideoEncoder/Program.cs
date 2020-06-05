namespace VideoEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video { Title = "My Video" };
            VideoEncoder encoder = new VideoEncoder();
            MailService mailService = new MailService();

            encoder.VideoEncoded += mailService.OnVideoEncoded;

            encoder.Encode(video);

        }
    }
}
