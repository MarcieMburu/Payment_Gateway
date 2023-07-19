namespace Payment_Gateway.Models
{
    public class Receiver : ValueObject
        {
         
            public string Name { get; private set; }
            public string ID_NO { get; private set; }
            public string Phone { get; private set; }
            public string Dst_Acc { get; private set; }


            public Receiver() { }

            public Receiver(string rec_Name, string rec_ID_NO, string rec_Phone, string rec_Dst_Acc)
            {
                Name = rec_Name;
                ID_NO = rec_ID_NO;
                Phone = rec_Phone;
                Dst_Acc = rec_Dst_Acc;
            }


            protected override IEnumerable<object> GetEqualityComponents()
            {
                // Using a yield return statement to return each element one at a time
                yield return Name;
                yield return ID_NO;
                yield return Phone;
                yield return Dst_Acc;

            }

        }
    }
