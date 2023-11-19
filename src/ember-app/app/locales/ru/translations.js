import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IIS9ДолжностиLForm from './forms/i-i-s-9-должности-l';
import IIS9ЗаписиLForm from './forms/i-i-s-9-записи-l';
import IIS9ЗаявкаLForm from './forms/i-i-s-9-заявка-l';
import IIS9КонтрагентLForm from './forms/i-i-s-9-контрагент-l';
import IIS9РегистрLForm from './forms/i-i-s-9-регистр-l';
import IIS9СотрудникLForm from './forms/i-i-s-9-сотрудник-l';
import IIS9ДолжностиEForm from './forms/i-i-s-9-должности-e';
import IIS9ЗаписиEForm from './forms/i-i-s-9-записи-e';
import IIS9ЗаявкаEForm from './forms/i-i-s-9-заявка-e';
import IIS9КонтрагентEForm from './forms/i-i-s-9-контрагент-e';
import IIS9РегистрEForm from './forms/i-i-s-9-регистр-e';
import IIS9СотрудникEForm from './forms/i-i-s-9-сотрудник-e';
import IIS9ДолжностиModel from './models/i-i-s-9-должности';
import IIS9ЗаписиModel from './models/i-i-s-9-записи';
import IIS9ЗаявкаModel from './models/i-i-s-9-заявка';
import IIS9КонтрагентModel from './models/i-i-s-9-контрагент';
import IIS9РегистрModel from './models/i-i-s-9-регистр';
import IIS9СотрудникModel from './models/i-i-s-9-сотрудник';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-9-должности': IIS9ДолжностиModel,
    'i-i-s-9-записи': IIS9ЗаписиModel,
    'i-i-s-9-заявка': IIS9ЗаявкаModel,
    'i-i-s-9-контрагент': IIS9КонтрагентModel,
    'i-i-s-9-регистр': IIS9РегистрModel,
    'i-i-s-9-сотрудник': IIS9СотрудникModel
  },

  'application-name': '9',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': '9',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: '9',
          title: '9'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        9: {
          caption: '9',
          title: '9',
          'i-i-s-9-регистр-l': {
            caption: 'Регистр',
            title: ''
          },
          'i-i-s-9-сотрудник-l': {
            caption: 'Сотрудник',
            title: ''
          },
          'i-i-s-9-заявка-l': {
            caption: 'Заявка',
            title: ''
          },
          'i-i-s-9-записи-l': {
            caption: 'Записи',
            title: ''
          },
          'i-i-s-9-должности-l': {
            caption: 'Должности',
            title: ''
          },
          'i-i-s-9-контрагент-l': {
            caption: 'Контрагент',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-9-должности-l': IIS9ДолжностиLForm,
    'i-i-s-9-записи-l': IIS9ЗаписиLForm,
    'i-i-s-9-заявка-l': IIS9ЗаявкаLForm,
    'i-i-s-9-контрагент-l': IIS9КонтрагентLForm,
    'i-i-s-9-регистр-l': IIS9РегистрLForm,
    'i-i-s-9-сотрудник-l': IIS9СотрудникLForm,
    'i-i-s-9-должности-e': IIS9ДолжностиEForm,
    'i-i-s-9-записи-e': IIS9ЗаписиEForm,
    'i-i-s-9-заявка-e': IIS9ЗаявкаEForm,
    'i-i-s-9-контрагент-e': IIS9КонтрагентEForm,
    'i-i-s-9-регистр-e': IIS9РегистрEForm,
    'i-i-s-9-сотрудник-e': IIS9СотрудникEForm
  },

});

export default translations;
