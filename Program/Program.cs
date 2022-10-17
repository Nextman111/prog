string[] ReturnStringLimit(string[] array, int limit){
    int lengthNewArray = 0; 
    for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= limit){
            lengthNewArray++;
        }
    }

    var result = new string[lengthNewArray]; 
    for(int i = 0, j = 0 ; j < result.Length; i++){
        if(array[i].Length <= limit){
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string[] array = {"hello","2","world", ":-)"};

int limit = 3;
var result = ReturnStringLimit(array, limit);
if (result.Length <1 )
    Console.WriteLine(" ");
else
    foreach (var el in result)
        Console.Write($"{el} ");