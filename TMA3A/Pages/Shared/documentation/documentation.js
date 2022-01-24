var learnButtons=document.querySelectorAll(".tabContainerDOC .buttonContainerDOC button");
var learnPanels=document.querySelectorAll(".tabContainerDOC .learnPanelDOC")


// Toggle to switch to different panels for different units
function showPanel1(panelIndex,colorCode) {
    learnButtons.forEach(function(node){
        node.style.backgroundColor="";
        node.style.color="";
    });
    learnButtons[panelIndex].style.backgroundColor=colorCode;
    learnButtons[panelIndex].style.color="white";
    
    
    learnPanels.forEach(function(node){
        node.style.display="none";
    });
    learnPanels[panelIndex].style.display="block";
    learnPanels[panelIndex].style.backgroundColor=colorCode;
}

showPanel1(0,'#2b2d33');

