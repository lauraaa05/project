const isProduction = import.meta.env.PROD;

const prod = "https://server-restless-haze-5740.fly.dev";
const dev = "http://localhost:5228";

export const finalUrl = isProduction ? prod : dev;