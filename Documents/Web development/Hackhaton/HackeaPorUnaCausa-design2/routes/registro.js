var express = require('express');
var router = express.Router();
var visitante = require('../model/visitantes')

/* GET home page. */
router.get('/', function(req, res, next) {
  res.render('registro', { title: 'Express' });
});

router.post('/', function(req, res, next) {
  var nombre=req.body.nombre;
  var fecha=req.body.fecha;
  var entrado_por=req.body.entradopor;
  var encargado = req.body.encargado;
  var pueblo=req.body.pueblo;
  var grado=req.body.grado;
  var clasificacion=req.body.clasificacion;
  var ofrecimiento=req.body.ofrecimiento;
  var cantidad=req.body.cantidad;
  var niños=req.body.ninos;
  var adultos=req.body.adultos;
  var seniors=req.body.seniors;
  var impedidos=req.body.impedidos;
  var maestros=req.body.maestros;
  var nocharge=req.body.nocharge;
  var total=req.body.total;
  var eventos=req.body.eventos ? req.body.eventos: 'Sin Evento';

  var visi = new visitante({
  nombre:nombre,
  fecha:fecha,
  admin:entrado_por,
  encargado:encargado,
  pueblo:pueblo,
  grado:grado,
  clasificacion:clasificacion,
  ofrecimientos:ofrecimiento,
  cantidad:cantidad,
  niños:niños,
  adultos:adultos,
  seniors:seniors,
  impedidos:impedidos,
  maestros:maestros,
  nocharge:nocharge,
  total:total,
  eventos:eventos

});


visi.save(function(err, vis) {
  if (err) return console.error(err);
  console.log("User name = "+ vis);
  res.json(vis);
});



});
module.exports = router;
