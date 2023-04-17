let urunler = [
    {
      isim: 'Erkek Gri Ayakkabı',
      fiyat: 1400,
      resim: "../assets/picture/erkek_gri_ayakkabı.png",
      aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
      id: "card-1",
      indx:0
    },
    {
        isim: 'Kadın Pantolon Siyah',
        fiyat: 600,
        resim: "../assets/picture/kadın_kot_siyah.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-2",
        indx:1
      },
      {
        isim: 'Erkek Beyaz Pantolon',
        fiyat: 720,
        resim: "../assets/picture/erkek_beyaz_pantolon.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-3",
        indx:2
      },
      {
        isim: 'Erkek Gri Pantolon',
        fiyat: 780,
        resim: "../assets/picture/erkek_gri_pantolon.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-4",
        indx:3

      },
      {
        isim: 'Erkek Kareli Pantolon',
        fiyat: 750,
        resim: "../assets/picture/erkek_kareli_pantolon.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-5",
        indx:4
      },
      {
        isim: 'Erkek Mavi Hırka',
        fiyat: 720,
        resim: "../assets/picture/erkek_mavi_hırka.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-6",
        indx:5
      },
      {
        isim: 'Erkek Tsirt',
        fiyat: 380,
        resim: "../assets/picture/erkek_tsirt.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-7",
        indx:6
      },
      {
        isim: 'Erkek Tsirt Kırmızı',
        fiyat: 210,
        resim: "../assets/picture/erkek_tsirt_kırmızı.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-8",
        indx:7
      },
      {
        isim: 'Kadın Kot Pantolon',
        fiyat: 470,
        resim: "../assets/picture/kadın_kot_pantolon.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-9",
        indx:8
      },
      {
        isim: 'Kadın Turuncu Hırka',
        fiyat: 280,
        resim: "../assets/picture/kadın_turuncu_hırka.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-10",
        indx:9
      },
      {
        isim: 'Kadın Çanta Takım',
        fiyat: 1235,
        resim: "../assets/picture/kadın_çanta_takım.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-11",
        indx:10
      },
      {
        isim: 'JBL Kulaklık',
        fiyat: 550,
        resim: "../assets/picture/kulaklık.png",
        aciklama: "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Maxime accusamus molestias animi recusandae, ab nostrum corrupti. Nostrum maxime inventore blanditiis!",
        id: "card-12",
        indx:11
      },
  ];
  
  
  for (let i = 1; i <= 12; i++) {

    const button = document.getElementById(`urun-${i}`);
    button.addEventListener('click', () => {
      const li = document.createElement('li');
      li.textContent = urunler[i-1].isim + " " + urunler[i-1].fiyat + " TL";
      const ul = document.getElementById('sepet-listesi');
      ul.appendChild(li);
    });
  }

  const buttonAra = document.getElementById("buton-ara");
  buttonAra.addEventListener("click", () => {
    let aranacakKelime = document.getElementById('textbox').value.toLowerCase();
    let filteUrunleri = urunler.filter(function(urun) {
      return urun.isim.toLowerCase().includes(aranacakKelime);
    });
    let mainDiv = document.querySelector("#main-div");
    mainDiv.innerHTML = ""; // önceki ürünleri temizledim

    filteUrunleri.forEach((urun) => {
      let cardHtml = `
        <div class="card col-md-3 me-auto">
          <img class="card-img-top" src="${urun.resim}" alt="Card image cap">
          <div class="card-body">
            <h5 class="card-title">${urun.isim}</h5>
            <p class="card-text">${urun.aciklama}</p>
            <a href="#" class="btn btn-outline-dark col-md-9" id="urun-${urun.indx}">Sepete Ekle</a>
            <i class="initialism d-flex justify-content-end">${urun.fiyat}₺</i>            
          </div>
        </div>
      `;
      mainDiv.innerHTML += cardHtml;
      //  let button = document.getElementById(`urun-${urun.indx}`);
      //   button.addEventListener('click', () => {
          
      //     const li = document.createElement('li');
      //     li.textContent = urun.isim + " " + urun.fiyat + " TL";
      //     const ul = document.getElementById('sepet-listesi');
      //     ul.appendChild(li);
      //  });    
    });  

    // document.querySelectorAll(".btn").addEventListener("click", function(){
    //   var li = document.createElement('li');
    //       li.textContent = urun.isim + " " + urun.fiyat + " TL";
    //       var ul = document.getElementById('sepet-listesi');
    //       ul.appendChild(li);
    // });

    // function AddEvent(){
    //   var btnList = document.querySelectorAll(".btn");
    //   for(var k=1;k<btnList.length;k++)
    //   {
    //       alert(k);
    //       btnList[k].addEventListener('click',  () => {      
    //         alert(k);  
    //       var li = document.createElement('li');
    //       li.textContent = urun.isim + " " + urun.fiyat + " TL";
    //       var ul = document.getElementById('sepet-listesi');
    //       ul.appendChild(li);
    //    }
    //    );
    //   }  
    // }  
    AddEvent();

  });

  function AddEvent(){
    var btnList = document.querySelectorAll(".btn");
    for(var k=1;k<btnList.length;k++)
    {      
        const button = document.getElementById(`urun-${k-1}`);
        button.addEventListener('click', () => {
          const li = document.createElement('li');
          li.textContent = urunler[k-1].isim + " " + urunler[k-1].fiyat + " TL";
          const ul = document.getElementById('sepet-listesi');
          ul.appendChild(li);
     }
     );
    }


  }

