using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "")
                    .Replace(")", "");// "1,2 2,3 4,5 6,7"

// string[] data = text.Split(" ");
//                  .ToArray();

var data = text.Split(" ") //разбили на элементы по разделителю пробел
                .Select(e => e.Split(','))//разделили элементы по разделителю запятая
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))//сделали из массива массивов - массив кортежей (сразу конвертировали в число), дали наименования элементам кортежа  
                .Where (e => (e.x%2 == 0))
                .Select (point => (point.x*10, point.y*10))
                .ToArray();
for (int i = 0; i < data.Length; i++){
    Console.WriteLine(data[i]);
    Console.WriteLine();
}

 
