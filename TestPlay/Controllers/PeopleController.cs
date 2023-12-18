using Microsoft.AspNetCore.Mvc;

[Route("PeopleController")]
public class People : Controller{
    
    private readonly IContats _contatoRepo;
    public People(IContats contats)
    {
        _contatoRepo = contats;
    }

    [Route("IndexPeople")]
   public IActionResult IndexPeople (){

        return View();
    }

     [Route("IndexCriar")]
    public IActionResult IndexCriar (){
        return View();
    }

    [HttpPost]
    public IActionResult IndexCriar(PersonModel person)
    {
        _contatoRepo.adicionar(person);
        return View();
    }
}