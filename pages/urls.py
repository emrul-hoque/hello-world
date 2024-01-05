# pages/urls.py
from django.urls import path
from .views import HomePageView, AboutPageView
#from .views import home_page_view

urlpatterns = [
    path("", HomePageView.as_view(), name="home"),
    path("about/", AboutPageView.as_view(), name="about"),
]