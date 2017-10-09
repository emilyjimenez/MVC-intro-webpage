using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Produces("text/html")]
        [Route("/")]
        public string Letter()
        {
          return
          "<!DOCTYPE html>" +
          "<html>" +
          "<head>" +
            "<title>Letter</title>" +
            "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css' integrity='sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u' crossorigin='anonymous'>" +
            "<link rel='stylesheet' href=/css/styles.css'>" +
          "</head>" +
          "<div class='container'>" +
          "<body>" +
            "<h1>Hello From Afar</h1>" +
            "<p>Dear Friend,</p>" +
            "<p>How are you? I hope that you are having a nice weekend. I'm learning programming while in Iceland! </p>" +
            "<p>Friend, you would not believe how cold it is here. I should have gone to Hawaii instead.</p>" +
            "<p>But I like programming a lot, so I've got that going for me. </p>" +
            "<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>" +
            "<p>Cheers,</p>" +
            "<p>Travel Enthusiast Jane</p>" +
          "</body>" +
          "</div>" +
          "</html>";
        }

        [Produces("text/html")]
        [Route("/favorite_photos")]
        public string FavoritePhotos()
        {
          return
          "<!DOCTYPE html>" +
          "<html>" +
          "<head>" +
            "<title>Favorite Photos</title>" +
            "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css' integrity='sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u' crossorigin='anonymous'>" +
            "<link rel='stylesheet' href=/css/styles.css'>" +
          "</head>" +
          "<div class='container'>" +
          "<body>" +
          "<h1>Favorite Photos from Unsplash</h1>" +
          "<ul>" +
          "<li><img src='/img/leaves.jpeg'/></li>" +
          "<li><img src='/img/monkey.jpeg'/></li>" +
          "<li><img src='/img/montain.jpeg'/></li>" +
          "</ul>" +
          "</body>" +
          "</div>" +
          "</html>";
        }
    }
}
