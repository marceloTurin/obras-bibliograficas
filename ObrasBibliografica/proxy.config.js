const proxy = [
    {
      context: '/api',
      target: 'http://localhost:51953/',
      pathRewrite: {'^/api' : ''}
    }
  ];
  module.exports = proxy;