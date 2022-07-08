string[] stringArray1 = {"hello",";)","HI!","True"};
string[] stringArray2 = {"1234","234","64575","-2"};
string[] stringArray3 = {"Russia","Denmark","Kazan","Turkey"};

void beginner(string[] str){
    List<string> ret = new List<string>();
    foreach(string s in str){
        if(s.Length<=3){
            ret.Add(s);
        }
    }
    foreach(string s in ret){
        Console.Write(s+" ");
    }
    Console.WriteLine("");
}

beginner(stringArray1);
beginner(stringArray2);
beginner(stringArray3);