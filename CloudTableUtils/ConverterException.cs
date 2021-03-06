using System;
namespace WebGate.Azure.CloudTableUtils {
    [Serializable]
    public class ConverterException:Exception {
        public ConverterException():base() {}
        public ConverterException(string message):base(message) {}
        public ConverterException(string message, Exception e):base(message, e) {}
        protected ConverterException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}