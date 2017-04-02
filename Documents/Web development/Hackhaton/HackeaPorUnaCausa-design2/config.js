var config = {
  mongoURL: process.env.MONGO_URL || 'mongodb://c3tec:12345678@ds147480.mlab.com:47480/c3tec',
  port: process.env.PORT || 8000
};

module.exports = config;
