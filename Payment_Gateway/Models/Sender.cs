namespace Payment_Gateway.Models
{
    public class Sender : ValueObject
    {
       
        public string Name { get; private set; }
        public string ID_NO { get; private set; }
        public string Phone { get; private set; }
        public string Src_Acc { get; private set; }


        public Sender() { }

        public Sender(string sen_Name, string sen_ID_NO, string sen_Phone, string sen_Src_Acc)
        {
            Name = sen_Name;
            ID_NO = sen_ID_NO;
            Phone = sen_Phone;
            Src_Acc = sen_Src_Acc;
        }


        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Using a yield return statement to return each element one at a time
            yield return Name;
            yield return ID_NO;
            yield return Phone;
            yield return Src_Acc;

        }

    }
}
