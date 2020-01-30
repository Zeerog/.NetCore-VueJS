using System;


namespace _03.Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Title Title = new Title();
            Author Author = new Author();
            Content Content = new Content();
            Book Book = new Book();
            Title.Text = "Эрагон";
            Author.Text = "Кристофер Паолини";
            Content.Text = "В волшебных лесах родной Алаганзии деревенский мальчик по имени Эрагон находит удивительной красоты голубой камень. Он собирается продать его, чтобы помочь своей" +
                " семье пережить зиму. К его изумлению, камень оказывается яйцом, из которого вылупляется прекрасный дракон, которого он называет Сапфира. В одну из ночей жизнь этого простого" +
                " мальчишки полностью переворачивается – с его семьей жестоко расправляются темные силы, которые обитают в королевстве. От старика сказочника Брома Эрагон узнает о своем особом" +
                " предназначении: он наездник драконов. Однако об этом знает и могущественный и вероломный король Галбатроикс, в прошлом также наездник драконов, который готов утопить все живое" +
                " в крови, чтобы остаться властелином плененной им Алаганзии. Эрагон и Сапфира – последняя надежда королевства на спасение от власти зла.";
            Book.SetTitle(Title);
            Book.SetAuthor(Author);
            Book.SetContent(Content);
            Book.Show();

            Console.ReadLine();
        }
    }
    class Book
    {
        string title;
        string author;
        string content;
        public void SetTitle(Title obj)
        {
            this.title = obj.Text;
        }
        public void SetAuthor(Author obj)
        {
            this.author = obj.Text;
        }
        public void SetContent(Content obj)
        {
            this.content = obj.Text;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
            Console.ResetColor();
        }

    }
    class Title
    {
        public string Text { get; set; }
        public void Show()
        {
            Console.WriteLine(Text);
        }
    }
    class Author
    {
        public string Text { get; set; }
        public void Show()
        {
            Console.WriteLine(Text);
        }
    }
    class Content
    {
        public string Text { get; set; }
        public void Show()
        {
            Console.WriteLine(Text);
        }
    }
}
