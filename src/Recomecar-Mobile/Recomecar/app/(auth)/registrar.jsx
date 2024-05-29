import { View, Text, StyleSheet, Pressable, ScrollView, Image, } from 'react-native'
import { Link, router } from "expo-router";
import { useState } from 'react'
import { SafeAreaView } from 'react-native-safe-area-context';
import {  handlePress } from 'react';

import { images } from '../../constants'
import FormField from '../../components/FormField';
import CustomButton from '../../components/CustomButton';

import { createUser } from '../../lib/appwrite'

const Registrar = () => {
  const [form, setForm] = useState({
    userName: '',
    email: '',
    password: ''
  })

const [IsSubmitting, setIsSubmitting] = useState(false)

const submit = () => {
  createUser();
}

  return (
    <SafeAreaView>
      <ScrollView>
        <View className='w-full justify-center min-h-[90vh] px-4 my-6'>
          <Image source={images.recomecarLogo}
          resizeMode='contain' className='w-[150px] h-[150px]'
          >
          </Image>

          <Text className='text-xl font-semibold mt-5 font-psemibold'>Registre sua conta Recomeçar</Text>
        
          <FormField
            title='Nome de Usuário'
            value={form.nomeUsuario}
            handleChangeText={(e) => setForm({ ...form, nomeUsuario: e })}
            otherStyles='mt-7'
          />
          <FormField
            title='Email'
            value={form.email}
            handleChangeText={(e) => setForm({ ...form, email: e })}
            otherStyles='mt-7'
            keyboardType='email-address'
          />
          <FormField
            title='Senha'
            value={form.senha}
            handleChangeText={(e) => setForm({ ...form, senha: e })}
            otherStyles='mt-7'
          />

          <CustomButton
            title="Registrar-se"
            handlePress={submit}
            containerStyles='mt-9'
            isLoading={IsSubmitting}
          />

          <View className='justify-center pt-8 flex-row gap-2'>
            <Text className='text-base font-pmedium'>
              Tem uma conta?
            </Text>

            <Link href="/login" className='text-lg font-psemibold text-secondary'>Entrar</Link>
          </View>
          
        </View>
      </ScrollView>
    </SafeAreaView>
    
  )
}

export default Registrar