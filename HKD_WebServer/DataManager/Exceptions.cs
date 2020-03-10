using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HKD_WebServer.DataManager
{
    public class Exceptions
    {
        [System.Serializable]
        public class UserDefunedException : ApplicationException
        {
            private string fileName;
            public string FileName { get { return fileName; } }
            public override string Message
            {
                get
                {
                    if (fileName == null) return base.Message;
                    else
                        return string.Format("В файле {0}  не указано количество вершин. Файл не может быть обработан", FileName);
                }
            }
            //Стандартные конструкторы
            public UserDefunedException() { }
            public UserDefunedException(string message) : base(message) { }
            public UserDefunedException(string message, Exception inner) : base(message, inner) { }
            protected UserDefunedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
            //Конструктор для свойства FileName
            public UserDefunedException(string message, string fileName) : this(message) { this.fileName = fileName; }
        }


        [System.Serializable]
        public class ExceptionFiltrator : ApplicationException
        {
            //Стандартные конструкторы
            public ExceptionFiltrator() { }
            public ExceptionFiltrator(string message) : base(message) { }
            public ExceptionFiltrator(string message, Exception inner) : base(message, inner) { }
            protected ExceptionFiltrator(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }

    }
}
