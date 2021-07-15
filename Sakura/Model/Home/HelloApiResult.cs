namespace Sakura.Model.Home
{
    public class HelloApiResult : NiProtocol
    {
        public long ServerTime { get; set; }
        public string WikiPath { get; set; }
        public string ServerMode { get; set; }
    }
}