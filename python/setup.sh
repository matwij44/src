#!/usr/bin/env bash
# put static files in /static
python ./manage.py collectstatic --no-input --no-default-ignore
# run website
exec gunicorn np_projekt.wsgi
