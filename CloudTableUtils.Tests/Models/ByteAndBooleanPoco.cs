using System;
using System.Text;
namespace WebGate.Azure.CloudTableUtilsTest {
    public class ByteAndBooleanPoco {
        public bool BoolValue {set;get;}

        public Boolean BooleanValue {set;get;}

        public byte[] ByteValue {set;get}

        public static ByteAndBooleanPoco Create() {
            ByteAndBooleanPoco bbp = new ByteAndBooleanPoco();
            bbp.BooleanValue = true;
            bbp.BoolValue = true;
            bbp.ByteValue = Encoding.UTF8.GetBytes("HELLO WORLD");
            return bbp;
        }
    }
}