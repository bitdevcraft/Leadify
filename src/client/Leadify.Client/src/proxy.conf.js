const { env } = require("process");

const target = env.ASPNETCORE_HTTPS_PORT ? `https://127.0.0.1:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] :  "https://127.0.0.1:7197";

console.log(target);
const PROXY_CONFIG = [
  {
    context: ["/api/WeatherForecast","/api/auth/login"],
    target,
    secure: false,
  },
];

module.exports = PROXY_CONFIG;
