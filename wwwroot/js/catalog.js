function fetchData(){

    $.ajax({
        url: '/Catalog/GetProperties',
        type:'GET',
        //data: JSON.stringify(objSend),
        contentType:'application/json',
        success: (data) => {
            //console.log(data.length);
            for(var x=0; x<data.length;x++){

                displayProperty(data[x]);
            }


        },
        error: (details) => {
            console.log("Error",details);

        }
    });

}

function Delete(){
    var id=1;
    
    $.ajax({
        url: '/Catalog/DeleteProperty/'+id,
        type:'DELETE',
        success: () => {
            console.log("Done");
        },
        error: (details) => {
            console.log("Error",details);
        }
    });

}

function displayProperty(prop){
    console.log(prop);
    //create the syntax
    var syntax = `<div class="property">
    <img src='${prop.imageUrl}' >
    <h4>${prop.title}</h4><hr>
    <p>Area: ${prop.area}</p>
    <p>Baths: ${prop.baths}</p>
    <hr>
    <p>Description: ${prop.description}</p>   
    <a href='#' onclick='Delete' >Eliminar</a>
    </div>`;
    //get the container
    var container=$("#catalog-container");
    //appen syntax to container

    container.append(syntax);


}

function init(){

    console.log("Catalog page");

    fetchData();

}

window.onload = init;