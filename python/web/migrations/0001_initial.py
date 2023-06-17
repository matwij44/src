from django.db import migrations, models
import django.db.models.deletion

class Migration(migrations.Migration):
    initial = True
    dependencies = []
    operations = [
        migrations.CreateModel(
            name='DodatkoweInfo',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('czas_trwania', models.PositiveSmallIntegerField(default=0)),
                ('gatunek', models.PositiveSmallIntegerField(choices=[(1, 'Horror'), (0, 'Inne'), (4, 'Drama'), (3, 'Sci-fi'), (2, 'Komedia')], default=0))
            ]
        ),
        migrations.CreateModel(
            name='Film',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('tytul', models.CharField(max_length=64, unique=True)),
                ('rok', models.PositiveSmallIntegerField(default=2000)),
                ('opis', models.TextField(default='')),
                ('premiera', models.DateField(blank=True, null=True)),
                ('imdb_rating', models.DecimalField(blank=True, decimal_places=2, max_digits=4, null=True)),
                ('plakat', models.ImageField(blank=True, null=True, upload_to='plakaty')),
                ('dodatkowe', models.OneToOneField(blank=True, null=True, on_delete=django.db.models.deletion.CASCADE, to='web.dodatkoweinfo'))
            ]
        ),
        migrations.CreateModel(
            name='Ocena',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('recenzja', models.TextField(blank=True, default='')),
                ('gwiazdki', models.PositiveSmallIntegerField(default=5)),
                ('film', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='web.film'))
            ]
        ),
        migrations.CreateModel(
            name='Aktor',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('imie', models.CharField(max_length=32)),
                ('nazwisko', models.CharField(max_length=32)),
                ('filmy', models.ManyToManyField(related_name='aktorzy', to='web.film'))
            ]
        )
    ]

