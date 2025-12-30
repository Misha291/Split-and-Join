public static string ReplaceIncorrectSeparators(string text)
{
    // Массив символов, которые считаем неправильными разделителями
    char[] separators = { ' ', ':', '-', ';', ',' };

    // Результат будем накапливать в StringBuilder для эффективности
    var result = new System.Text.StringBuilder();

    bool lastWasTab = false; // следим, чтобы не вставлять несколько табов подряд

    foreach (char c in text)
    {
        if (separators.Contains(c))
        {
            // Если предыдущий символ не был табуляцией, добавляем таб
            if (!lastWasTab)
            {
                result.Append('\t');
                lastWasTab = true;
            }
        }
        else
        {
            result.Append(c);
            lastWasTab = false;
        }
    }

    return result.ToString();
}
