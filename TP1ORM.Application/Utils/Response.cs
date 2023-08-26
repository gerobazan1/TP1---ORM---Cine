using System.Collections;
namespace TP1ORM.Application.Utils
{
    public class Response
    {
        public bool Succes { get; set; }
        public string Content { get; set; }
        public object Objects { get; set; }
        public ArrayList List { get; set; }
        public Response(bool succes, string content)
        {
            Succes = succes;
            Content = content;
        }
    }
}
