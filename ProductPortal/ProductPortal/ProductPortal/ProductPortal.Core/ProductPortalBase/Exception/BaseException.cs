using System.Runtime.Serialization;

namespace ProductPortal.Core.ProductPortalBase.Exception
{
    public abstract class BaseException : RankException
    {
        public virtual string ExceptionType => "BaseException";

        public object[] PropertyValues { get; }
        public string MessageTemplate { get; }

        protected BaseException()
        {
        }
        protected BaseException(string message)
            : base(message)
        {
        }
        protected BaseException(string message, RankException innerException)
            : base(message, innerException)
        {
        }
        protected BaseException(string messageTemplate, params object[] propertyValues)
            : base(messageTemplate)
        {
            PropertyValues = propertyValues;
            MessageTemplate = messageTemplate;
        }
        protected BaseException(string messageTemplate, RankException innerException, params object[] propertyValues)
            : base(messageTemplate, innerException)
        {
            PropertyValues = propertyValues;
            MessageTemplate = messageTemplate;
        }
        protected BaseException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }
    }
}
