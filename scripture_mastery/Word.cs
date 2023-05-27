public class Word
{
    string _word;
    bool _IsShown;

    public Word(string word)
    {
        _word = word;
        _IsShown = true;
    }
    public void DisplayWord (){
        if (_IsShown == false) {
            foreach ( char letter in _word){
                Console.Write("_");
            }
            Console.Write(" ");
        }
        else{
                Console.Write($"{_word} ");
        }
        
    
    }
    //   public string GetWordAsString()
    // {

    // }
    
    // public bool CheckIfShown()
    // {

    // }

    public void HideWord()
    {
       _IsShown = false;  
    }
}    


