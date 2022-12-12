FROM node:latest as build-angular
ENV NODE_OPTIONS="--openssl-legacy-provider"
WORKDIR /dist/src/apps
RUN npm cache clean --force
COPY . .

RUN npm install
RUN npm run build --prod

FROM nginx:latest AS ngi
COPY --from=build-angular /dist/src/apps/dist/stefanini-crud.client /usr/share/nginx/html
COPY ./nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80
