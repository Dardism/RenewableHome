$('#drpState').change(function () {
  $('#txtKWperMonth').val(this.value).css('border-color', 'green').css('border-width', '3px');
})


//slider 
$("#sliderSolar").slider();
$("#sliderSolar").on("slide", function (slideEvt) {
  $("#sliderSolarSliderVal").text(slideEvt.value);
});

$("#sliderWind").slider();
$("#sliderWind").on("slide", function (slideEvt) {
  $("#sliderWindSliderVal").text(slideEvt.value);
});

$("#sliderHydro").slider();
$("#sliderHydro").on("slide", function (slideEvt) {
  $("#sliderHydroSliderVal").text(slideEvt.value);
});

$("#sliderGeo").slider();
$("#sliderGeo").on("slide", function (slideEvt) {
  $("#sliderGeoSliderVal").text(slideEvt.value);
});

$("#sliderNuclear").slider();
$("#sliderNuclear").on("slide", function (slideEvt) {
  $("#sliderNuclearSliderVal").text(slideEvt.value);
  $('#Value').val(slideEvt.value);
});