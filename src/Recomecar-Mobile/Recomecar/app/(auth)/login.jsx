import { View, Text, StyleSheet, Pressable, ScrollView, Image, Alert } from 'react-native'
import { Link, router } from "expo-router";
import { useState } from 'react'
import { SafeAreaView } from 'react-native-safe-area-context';
import {  handlePress } from 'react';

import { images } from '../../constants'
import FormField from '../../components/FormField';
import CustomButton from '../../components/CustomButton';

import { signIn } from '../../lib/appwrite'


const Login = () => {
  const [isSubmitting, setSubmitting] = useState(false);
  const [form, setForm] = useState({
    username: "",
    email: "",
    password: "",
  });

  const submit = async () => {
    if (form.email === "" || form.password === "") {
      Alert.alert("Error", "Por favor, preencha todos os campos");
    }

    setSubmitting(true);

    try {
      await signIn(form.email, form.password);

    } catch (error) {
      Alert.alert("Erro", error.message);
    } finally {
      setSubmitting(false);
    }
  };

  return (
    <SafeAreaView>
      <ScrollView>
        <View className='w-full justify-center min-h-[90vh] px-4 my-6'>
          <Image source={images.recomecarLogo}
          resizeMode='contain' className='w-[150px] h-[150px]'
          >
          </Image>

          <Text className='text-xl font-semibold mt-5 font-psemibold'>Entre na sua conta Recomeçar</Text>
        
          <FormField
            title='Email'
            value={form.email}
            handleChangeText={(e) => setForm({ ...form, email: e })}
            otherStyles='mt-7'
            keyboardType='email-address'
          />
          <FormField
            title='Senha'
            value={form.password}
            handleChangeText={(e) => setForm({ ...form, password: e })}
            otherStyles='mt-7'
          />

          {/* Alterar para a função submit quando o backend estiver pronto */}
          <CustomButton
            title="Entrar"
            handlePress={submit}
            containerStyles='mt-9'
            isLoading={isSubmitting}
          />

          <View className='justify-center pt-8 flex-row gap-2'>
            <Text className='text-base font-pmedium'>
              Não tem uma conta?
            </Text>

            <Link href="/registrar" className='text-lg font-psemibold text-secondary'>Registrar-se</Link>
          </View>
          
        </View>
      </ScrollView>
    </SafeAreaView>
    
  )
}

export default Login