
string text = "У лукоморья дуб зелёный;"
            + "Златая цепь на дубе том:"
            + "И днём и ночью кот учёный"
            + "Всё ходит по цепи кругом;"
            + "Идёт направо — песнь заводит,"
            + "Налево — сказку говорит."
            + "Там чудеса: там леший бродит,"
            + "Русалка на ветвях сидит;";


string Replace (string text, char oldValue, char newValue){
    string result = String.Empty;
     for (int i = 0; i < text.Length; i++) {
        if (text[i] == oldValue) result = result + newValue;
        else { result = result + text[i];}
    }
    return result;
} 

Console.WriteLine(Replace(Replace(Replace(Replace(Replace(Replace(Replace(text, 'Р', 'р'), 'Т', 'т'), 'Н', 'н'), 'В', 'в'), 'И', 'и'), 'З', 'з'), 'У', 'у'));
