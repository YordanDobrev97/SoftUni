namespace SIS.HTTP
{
    public class FileResponse : HttpResponse
    {
        public FileResponse(byte[] byteContent, string contentType)
        {
            this.StatusCode = HttpResponseCode.Ok;
            this.Body = byteContent;
            this.Headers.Add(new Header("Content-Type", contentType));
            this.Headers.Add(new Header("Content-Length", this.Body.Length.ToString()));
        }
    }
}
