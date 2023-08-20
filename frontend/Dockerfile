FROM node:19.8.1-alpine as builder
RUN npm i -g pnpm
WORKDIR /app
COPY package.json pnpm-lock.yaml ./
COPY . .
RUN pnpm i 
COPY . ./
EXPOSE 3000 
RUN pnpm build

FROM nginx:stable-alpine
WORKDIR /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=builder /app/dist ./