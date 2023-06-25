function loginUsuario(){
  var user = document.getElementById("userId").value;
  var senha = document.getElementById("senhaId").value;
  if (user === "administrador" && senha === "12345") {
    alert ("Login efetuado com sucesso");
    window.location.replace("informacao.html");
  } else if (user === "rechumanos" && senha === "12345") {
    alert ("Login efetuado com sucesso");
    window.location.replace("informacao.html");
  } else if (user === "comercial" && senha === "12345") {
    alert ("Login efetuado com sucesso");
    window.location.replace("informacao.html");
  } else if (user === "tecinfo" && senha === "12345") {
    alert ("Login efetuado com sucesso");
    window.location.replace("informacao.html");
  } else if (user === "financeiro" && senha === "12345") {
    alert ("Login efetuado com sucesso");
    window.location.replace("/CatarinaSea/informacao/informacao.html");
  } else {
    alert ("Login incorreto");
    window.location.replace("login.html");
    }
  }