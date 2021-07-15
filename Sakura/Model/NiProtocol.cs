namespace Sakura.Model
{
    public class NiProtocol
    {
        public string Message { get; set; }
        public NiErrCode Code { get; set; }

        public NiProtocol()
        {
        }

        public NiProtocol(NiErrCode code, string message)
        {
            Message = message;
            Code = code;
        }
    }
}