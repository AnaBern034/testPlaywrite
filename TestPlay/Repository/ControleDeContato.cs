public class ControleDeContato : IContats
{
    private readonly Banco _bancoContext;
    public ControleDeContato(Banco bancoContext)
    {
     _bancoContext = bancoContext;   
    }
    public PersonModel adicionar(PersonModel personModel)
    {
       _bancoContext.Friends.Add(personModel);
       _bancoContext.SaveChanges();
       return personModel;
    }
}