using System;
using System.Collections.Generic;
using System.Text;

namespace ConstruirString.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Coment> Coments { get; set; } = new List<Coment>();
        
        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        //padrao
        public void AddComent(Coment coment)
        {
            Coments.Add(coment);
        }

        public void RemoveComent(Coment coment)
        {
            Coments.Remove(coment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            foreach(Coment c in Coments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
