function deleteRow() {

    //input type = "button" value = "Delete Row" onclick = "document.getElementById('newtable').deleteRow(0)" >
    var removeRow = document.getElementsByClassName('removeLink')
    for (var i = 0; i < removeRow.length; i++) {
        var button = removeRow[i]
        button.addEventListener('click', removeRowi)
    }
}
function removeRowi(event) {
    var buttonClicked = event.target
    buttonClicked.closest('tr').remove();

}