let session = "Зимна";
let year = new Date().getFullYear();
function changeSelect() {
    let div = document.getElementById("showhide");
    let temp = 1;
    year = new Date().getFullYear();
    let month = new Date().getMonth() + 1;

    if (month >= 2 && month < 9) {
        session = "Лятна";
    }
    if (month < 9) {
        year -= 1;
    }
    let selected = document.getElementById("mySelect").value;
    if (selected === "--Избери--") {
        div.style.display = "none";
    }

    else {
        div.style.display = "block";
        console.log(selected);
        let insertinfo = document.getElementById("insertinfohere");
        insertinfo.innerHTML = null;
        for (let i = 1; i <= 4; i++) {
            insertinfo.innerHTML += `<tr>
                            <td>${year}/${year + 1}</td>
                            <td>${session}</td>
                            <td>${selected}</td>
                            <td>${temp++}</td>
                            <td>
                                
                                    <button id="${selected}+${temp - 1}" onclick="Fill(this.id)" type="button">Download</button>
                                
                            </td>
                        </tr>`

        }

    }
    //<a href="/Download/Exam" download="Programa"> </a>
}
function Fill(fullinfo) {
    const info = fullinfo.split('+');
    let faculty = info[0];
    let shortFaculty = "";
    for (let i = 0; i < faculty.length; i++) {
        if (faculty[i] === faculty[i].toUpperCase() && faculty[i].toLowerCase() !== faculty[i].toUpperCase()) {
            shortFaculty += faculty[i];
        }
    }
    
    let courseNumber = info[1];
    window.location.replace (`/Download/FillExamFormAsync?facultyname=${faculty}&coursenumber=${courseNumber}&session=${session}&year=${year}&shortFaculty=${shortFaculty}`);

    //$.ajax(
    //    {
    //        type: "GET",
    //        url: "/Download/FillExamFormAsync",
    //        data:
    //        {
    //            faculty: faculty,
    //            course: courseNumber,
    //            session: session,
    //            year: year
    //        },
    //        success: function (data) {
    //            console.log(data);
    //            window.location = `@Url.Action("Download", "FillExamFormAsync", new { faculty = ${faculty}, course = ${courseNumber}, session=${session}, year=${year}  })`;
    //            //let pdf = new jsPDF('p', 'pt', 'a4');
    //            //pdf.addHTML(response);
    //            //console.log(pdf);
    //            //pdf.save('web.pdf');

    //            //let hxr = new XMLHttpRequest();
    //            //hxr.responseType = 'blob';
    //            //hxr.onreadystatechange = function () {

    //            //}
    //            //console.log(String(data));
    //            //let datatosend = JSON.stringify(data);
    //            //console.log(datatosend);
    //            //$.ajax({
    //            //    type: 'get',
    //            //    url: "Download/Test",
    //            //    data: {
    //            //        MyHtml: 'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
    //            //    }

    //            //})
    //            //console.log(typeof ((data)));
    //            //let binaryData = [];
    //            //binaryData.push(data);
    //            //let newBlob = new Blob(binaryData, { type: "application/pdf" })
    //            //console.log(newBlob);
    //            //let url = window.URL.createObjectURL(newBlob);
    //            //console.log(url);   
    //            //let a = document.createElement('a');
                 
    //            //a.href = url;
    //            //console.log(a);
    //            //a.download = `${shortFaculty}.${courseNumber}.pdf`;
    //            //document.body.append(a);
    //            //a.click();
    //            //a.remove();
    //            //window.URL.revokeObjectURL(url);


    //        }
    //    });
}