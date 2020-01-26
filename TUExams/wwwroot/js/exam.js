let faculty = document.getElementById("selectFaculty").value;
let startTime = document.getElementById("selectTime").value;
let course = document.getElementById("selectCourse").value;



function changeCourse() {
    course = document.getElementById("selectCourse").value;
}
function changeFaculty() {
    faculty = document.getElementById("selectFaculty").value;
}
function changeTime() {
    startTime = document.getElementById("selectTime").value;
}

$('#createExam').on('click', () => {
    let isEverythingOk = true;
    let examname = document.getElementById("examname").value;
    let hall = document.getElementById("zala").value;
    let day = document.getElementById("date").value;
    let duration = document.getElementById("duration").value;



    if (examname === "") {
        isEverythingOk = false;
        $('#wrongexamname').text("Моля въведете име на изпита");
    }
    else {
        $('#wrongexamname').text("");

    }

    if (duration === "") {
        isEverythingOk = false;
        $('#wrongduration').text("Моля въведете продължителност на изпита");
    }
    else if (duration < 60) {
        isEverythingOk = false;
        $('#wrongduration').text("Изпитът не може да бъде по-къс от един час!");
    }
    else if (duration > 180) {
        isEverythingOk = false;
        $('#wrongduration').text("Изпитът не може да бъде по-дълъг от три часа!");
    }
    else {
        $('#wrongduration').text("");
    }


    if (hall.length !== 4 && hall.length !== 5) {
        isEverythingOk = false;
        $('#wrongHall').text("Моля въведете зала, която съществува");
    }
    else if (hall.length === 5 && (hall[0] !== 1 || hall[1] !== 2)) {
        isEverythingOk = false;
        $('#wrongHall').text("Моля въведете зала, която съществува");
    }
    else if (hall.length === 4 && hall[1] > 6) {
        isEverythingOk = false;
        $('#wrongHall').text("Моля въведете зала, която съществува");
    }
    else if (hall.length === 5 && hall[2] > 6) {
        isEverythingOk = false;
        $('#wrongHall').text("Моля въведете зала, която съществува");
    }
    else {
        $('#wrongHall').text("");
    }

    let dayarray = day.split("/");
    if (dayarray.length !== 3) {
        isEverythingOk = false;
        $('#wrongDay').text("Моля въведете ден месец и година в този вид: dd/mm/yy")
    }
    else if (dayarray[0] < 0 || dayarray[0] > 31) {
        isEverythingOk = false;
        $('#wrongDay').text("Моля въведете валиден ден");
    }
    else if (dayarray[1] < 0 || dayarray[1] > 12) {
        isEverythingOk = false;
        $('#wrongDay').text("Моля въведете валиден месец");
    }
    else if (dayarray[2] !== "2020") {
        isEverythingOk = false;
        $('#wrongDay').text("Моля въведете 2020 година");
    }
    else {
        $('#wrongDay').text("");
    }
    if (isEverythingOk) {
        $.ajax({
            type: 'Post',
            url: 'Exam/CreateExamAsync',
            headers: {
                RequestVerificationToken:
                    $('input:hidden[name="__RequestVerificationToken"]').val(),
            },
            data: {
                facultyname: faculty,
                day: day,
                hall: hall,
                duration: duration,
                course: course,
                startTime: startTime,
                examname: examname,
            },
            success: function (data) {
                console.log(data);
                if (data === "false examname") {
                    $('#wrongexamname').text("Вече съществува такъв изпит за този факултет")
                }
                else {
                    $('#wrongexamname').text();
                }
                if (data === "false dayandhall") {
                    $('#wrongHall').text("Тази зала е заета на този ден и този час!");
                }
                else {
                    $('#wrongHall').text();
                }
                if (data === "true") {
                    window.location.replace("/Exam");
                }
            }
        })
    }
})