using System;


namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {            
                Console.WriteLine("Введите ключ доступа или нажмите Enter чтобы использовать бесплатную версию:");
                String key = Console.ReadLine();
                DocumentWorker user;
                Mode whatMode = ValidKey(key);
                switch (whatMode)
                {
                    case Mode.pro:
                        user = new ProDocumentWorker();
                        break;
                    case Mode.exp:
                        user = new ExpertDocumentWorker();
                        break;
                    default:
                        user = new DocumentWorker();
                        break;
                }

                user.OpenDocument();
                user.EditDocument();
                user.SaveDocument();

                Console.ReadLine();

        }

        static Mode ValidKey(String key)
        {
            if (key == "pro")
                return Mode.pro;
            else if (key == "exp")
                return Mode.exp;
            else return Mode.def;
        }
    }

    public enum Mode
    {
        pro,
        exp,
        def
    }
     public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    public class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    public class ExpertDocumentWorker: ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

}
