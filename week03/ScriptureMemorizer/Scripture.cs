public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<int> _position = new List<int>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> temp = text.Trim().Split(' ').ToList();
        foreach(string item in temp)
        {
            Word newWord = new Word(item);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int currentAmount = 0;
        while(currentAmount < numberToHide)
        {
            if(_words.Count == _position.Count)
            {
                break;
            }
            Random rnd = new Random();
            int randomNumber = rnd.Next(_words.Count);
            if (_position.Contains(randomNumber))
            {
                continue;
            }
            else
            {
                _position.Add(randomNumber);
                _words[randomNumber].Hide();
                currentAmount += 1;
            }
        } 
    }
    public string GetDisplayText()
    {
        string temp = _reference.GetDisplayText();
        foreach(Word item in _words)
        {
            temp += $" {item.GetDisplayText()}";
        }
        return temp;
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word item in _words)
        {
            if (item.IsHidden())
            {
                continue;
            } 
            else
            {
                return false;    
            }
        }
        return true;
    }

}