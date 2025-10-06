import {TodoClient} from "./generated-ts-client.ts";

const isProduction = import.meta.env.PROD;

const prod = "https://server-restless-haze-5740.fly.dev";
const dev = "http://localhost:5013";

export const finalUrl = isProduction ? prod : dev;

export const todoClient = new TodoClient(finalUrl);