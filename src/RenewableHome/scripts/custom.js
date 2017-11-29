$('#drpState').change(function () {
  $('#txtKWperMonth').val(this.value).css('border-color', 'green').css('border-width', '3px');
  })