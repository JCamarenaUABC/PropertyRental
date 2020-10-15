var UI ={}; //INICIALIZADOR DEL OBJETO

class Register{
    /*    *Initialize elements  */
    constructor (Title,Price,ImageUrl,Beds,Baths,Description, Parking, Area ){
        this.Title=Title;
        this.Price=Price;
        this.ImageUrl=ImageUrl;
        this.Beds=Beds;
        this.Baths=Baths;
        this.Description=Description;
        this.Parking=Parking;
        this.Area=Area;
        
        this.user="Jesus";
        this.createdOn=new Date();
    }
}

///////////////////////////////////

function clearInputs(){
    $(".control").val("");
}

function saveProperty(){
    //Get Values
    var Price =parseInt( UI.txtPrice.val());
    var Title = UI.txtTitle.val();
    var Image = UI.txtImageUrl.val();
    var Beds = parseInt(UI.txtBeds.val());
    var Baths = parseInt(UI.txtBaths.val());
    var Description = UI.txtDescription.val();
    var Area = parseInt(UI.txtArea.val());

    /*if(!Price){
        alert('Error prices!!!');
        return;
    }*/

    var Radio = true;// UI.rbRadio0.val();
    if(UI.rbRadio1.val()){
        Radio = false; //UI.rbRadio1.val();
    }

    var objSend = new Register(Title,Price,Image,Beds,Baths,Description,Radio, Area);
//    var objSend = new Register(UI.Price.val(),UI.Title.val(), UI.ImgeUrl.val(), UI.Beds.val(), UI.Baths.val(), UI.Description.val(), Radio);

    //Send obj
    console.log(objSend);
    $.ajax({
        url: '/Catalog/SaveProperty',
        type:'POST',
        data: JSON.stringify(objSend),
        contentType:'application/json',
        success: (res) => {
            console.log(res);
            
            $(".modal-content").css("background-color","green");
            $('#exampleModalLabel').text("Success");
            $('.modal-body').html("Done!!!");
            $('#exampleModal').modal('show');
            clearInputs();

        },
        error: (details) => {
            console.log("Error",details);

            $(".modal-content").css("background-color","red");
            $('#exampleModalLabel').text("Error");
            $('.modal-body').html("Error: "+details.responseText);
            $('#exampleModal').modal('show');
            //alert(`Error ${details}!!!`);
        }
    });


    //Clear the form
    //show an message
}

function init(){

    //console.log("Register");

    UI = {     
        txtPrice: $("#txtPrice"),
        txtTitle: $("#txtTitle"),
        txtImageUrl: $("#txtImageURL"),
        txtBeds: $("#txtBeds"),
        txtBaths: $("#txtBaths"),
        txtDescription: $("#txtDescription"),
        txtArea: $("#txtArea"),
        rbRadio0: $("#rbRadio_0"),
        rbRadio1: $("#rbRadio_1"),
        btnSave: $("#btnSave")
    }

    //event
    UI.btnSave.click(saveProperty);

}

window.onload = init;