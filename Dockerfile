FROM node:18

COPY . /app

WORKDIR /app

RUN

EXPOSE 3000

CMD [ "npm", "start"]