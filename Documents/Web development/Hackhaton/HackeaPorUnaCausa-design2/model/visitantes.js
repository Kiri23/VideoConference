var mongoose = require('mongoose');
var visitanteSchema = new mongoose.Schema({
  nombre: String,
  fecha: Date,
  admin: String,
  encargado:String,
  pueblo: String,
  grado: String,
  clasificacion: String,
  ofrecimientos: String,
  niños: Number,
  adultos: Number,
  senior: Number,
  impedidos: Number,
  maestros: Number,
  nocharge: Number,
  total: Number,
  eventos: String
});

// Compile a 'Movie' model using the movieSchema as the structure.
// Mongoose also creates a MongoDB collection called 'Movies' for these documents.
var Visitante = mongoose.model('Visitante', visitanteSchema);

module.exports = Visitante;
