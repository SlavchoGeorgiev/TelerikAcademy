/*
Refactor the following examples to produce code with well-named identifiers in JavaScript

 function _ClickON_TheButton( THE_event, argumenti) {
  var moqProzorec= window,
      brauzyra = moqProzorec.navigator.appCodeName,
      ism=brauzyra=="Mozilla";
  if(ism) {
    alert("Yes");
  } else {
    alert("No");
  }
}
 */

function AlertIsMozilla() {
    var isMozilla,
        currentBrouser = window.navigator.appCodeName;

    isMozilla = currentBrouser === "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}