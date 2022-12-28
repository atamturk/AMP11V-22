function modalGoster() {
    document.getElementById("myModal").
    style.display = "block";
}

function closeModal() {
    document.getElementById("myModal").
    style.display = "none";
  }
  var time=10;
  //const  sayac = setInterval(mesajGoster,1000);
  function mesajGoster() {  
       
       document.getElementById("goster").innerHTML += "<h1>" + time + "</h1>";
       time--;
    if (time == 0) {
        durdur();
    }
  }

  function durdur() {
    clearInterval(sayac);
  }

  function kontrolEt() {
    var ad,soyad,email,sifre,t_sifre;
    var regex = /^[a-zA-Z0-9._-]+@([a-zA-Z0-9.-]+.)+([.])+[a-zA-Z0-9.-]{2,4}$/;
    sifre = document.getElementById("sifre").value;
    t_sifre = document.getElementById("t_sifre").value;
    ad = document.getElementById("ad").value;
    email = document.getElementById("email").value;
    if(ad == ""){
     document.getElementById("hata").innerHTML += "Ad kısmını boş bırakmayınız." + "<br>"; 
    } 
    if(sifre != t_sifre){
      document.getElementById("hata").innerHTML += "Şifreler aynı olmalı"; 
    } 
    if(regex.test(email)==false){
      document.getElementById("hata").innerHTML += "Mailinizi kontrol ediniz"; 
    }
  }