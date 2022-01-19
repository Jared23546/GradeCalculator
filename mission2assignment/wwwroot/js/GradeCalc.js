//run when the button is clicked
$('#calc').click(function () {

    //set the variables
    var numberGrade;
    let letterGrade;

    //calculate numberGrade
    numberGrade = (($('#Assignments').val() * .55) +
                   ($('#GroupProject').val() * .05) +
                   ($('#Quizes').val() * .1) +
                   ($('#Exams').val() * .2) +
                   ($('#Intex').val() * .1));



    //determine the letter grade based on numberGrade
    if (numberGrade >= 94) {
        letterGrade = "A";
    }
    else if (numberGrade >= 90) {
        letterGrade = "A-";
    }
    else if (numberGrade >= 87) {
        letterGrade = "B+";
    }
    else if (numberGrade >= 84) {
        letterGrade = "B";
    }
    else if (numberGrade >= 80) {
        letterGrade = "B-";
    }
    else if (numberGrade >= 77) {
        letterGrade = "C+";
    }
    else if (numberGrade >= 74) {
        letterGrade = "C";
    }
    else if (numberGrade >= 70) {
        letterGrade = "C-";
    }
    else if (numberGrade >= 67) {
        letterGrade = "D+";
    }
    else if (numberGrade >= 64) {
        letterGrade = "D";
    }
    else if (numberGrade >= 60) {
        letterGrade = "D-";
    }
    else {
        letterGrade = "E";
    }

    //send the alert that will inform the user of both the letter and number grade
    alert("You have a " + numberGrade + "% (" + letterGrade + ") in the class");
})