  <?php
  session_start();
  // on "lance" doctrine
  require_once "bootstrap_doctrine.php";
  
  // on indique que l'on a besoin de certaines classes
  require_once "classes/Admin.php";
  require_once "classes/Competence.php";
  require_once "classes/Etudiant.php";
  require_once "classes/Examinateur.php";
  require_once "classes/Professeur.php";
  require_once "classes/Statut.php";
  require_once "classes/Utilisateur.php";
  require_once "classes/Validation.php";
?>

  <!doctype html>
  <html lang="en">
  <head>
    <meta charset="UTF-8">
    <title>PPE-14 Login</title>
  <link rel="stylesheet" href="css/bootstrap.min.css">
  <link rel="stylesheet" href="css/main.css">
  </head>
  <body>
    <div class="row" id="login">
      <div class="col-lg-4">
        <h2 class="text-muted">Merci de bien vouloir vous identifier</h2>
      </div>
      <div class="col-lg-3">
      <form action="script/connect.php" method="post" class="form">  
        <input type="text" class="form-control" id="username" name="user_login" placeholder="Nom d'utilisateur" required autofocus>
        <input type="password" class="form-control" id="password" name="user_pwd" placeholder="Mot de passe" required>
        <button class="btn btn-lg btn-primary btn-block" type="submit">Se connecter</button>
      </form>
    </div>
   </div>
  </div>
    <script src="js/jquery-1.10.2.js"></script>
    <script src="js/bootstrap.min.js"></script>
  </body>
  </html>
  <div class="content">
