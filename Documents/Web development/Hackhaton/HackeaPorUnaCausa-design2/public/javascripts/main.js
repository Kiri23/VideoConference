var btnanadir = $('#anadir');


btnanadir.click(function() {
  var nombre = $('#nombre').val();
  var fecha = new Date();
  var entrado_por = $('#entrado_por').val();
  var encargado = $('#encargado').val();
  var pueblo = $('#pueblo').val();
  var grado = $('#grado').val();
  var clasificacion = $('#clasificacion').val();
  var ofrecimiento = $('#ofrecimiento').val();
  var cantidad = parseInt($('#cantidad').val(),10);
  var niños = parseInt($('#ninos').val(),10);
  var adultos = parseInt($('#adultos').val(),10);
  var seniors = parseInt($('#seniors').val(),10);
  var impedidos = parseInt($('#impedidos').val(),10);
  var maestros = parseInt($('#maestros').val(),10);
  var nocharge  = parseInt($('#nocharge').val(),10);
  var total = cantidad + niños + adultos + seniors + impedidos + maestros + nocharge;
  console.log(total);
  var eventos = $('#eventos').val();

  $.post( "/registro",{'nombre':nombre,'fecha': fecha,'entrado_por':entrado_por,
                       'encargado':encargado,'pueblo':pueblo,'grado':grado,
                       'clasificacion':clasificacion,'ofrecimiento':ofrecimiento,
                       'cantidad':cantidad,'niños':niños,'adultos':adultos,'seniors':seniors,
                       'impedidos':impedidos,'maestros':maestros,'nocharge':nocharge,'total':total,
                       'eventos':eventos }, function( data ) {
      console.log(data);;
  });
});
