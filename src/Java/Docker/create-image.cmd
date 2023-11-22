docker build --no-cache -f SQL\Dockerfile.PostgreSql -t 9-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t 9-java/app ../../..
